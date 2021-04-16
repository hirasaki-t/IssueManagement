import { Meta, Story } from "@storybook/react/types-6-0";
import Question from "../components/Question";
import StoryRouter from 'storybook-react-router';

export default {
    title: "components/Question",
    decorators: [StoryRouter()],
    components: Question,
} as Meta;

const Template: Story = () => <Question />;

export const Default = Template.bind({});