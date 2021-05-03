import { Meta, Story } from "@storybook/react/types-6-0";
import TextInput from "../components/TextInput";
import StoryRouter from 'storybook-react-router';

export default {
    title: "components/TextInput",
    decorators: [StoryRouter()],
    components: TextInput,
} as Meta;

const Template: Story = () => <TextInput />;

export const Default = Template.bind({});