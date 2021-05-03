import { Meta, Story } from "@storybook/react/types-6-0";
import Drawers from "../components/Drawers";
import StoryRouter from 'storybook-react-router';

export default {
    title: "components/Drawers",
    decorators: [StoryRouter()],
    components: Drawers,
} as Meta;

const Template: Story = () => <Drawers />;

export const Default = Template.bind({});